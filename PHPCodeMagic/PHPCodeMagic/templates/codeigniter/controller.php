<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class {TABLE} extends MY_Controller {

    public function __construct() {
        parent::__construct();
    }

	public function index()
	{
        $this->load->model('{table}_model');
        $data = [
            'models' => $this->{table}_model->all(),
        ];
		$this->load->view('{table}/index', $data);
    }

    public function info($id)
    {
        $this->load->model('{table}_model');
        $data = [
            'model' => $this->{table}_model->get($id),
        ];
        $this->load->view('{table}/info', $data);
    }

    public function add()
    {
        $data = [
            'random_password' => random_string('alnum', 8),
        ];
        $this->load->view('{table}/add', $data);
    }

    public function delete($id)
    {
        $this->load->model('{table}_model');
        $this->{table}_model->delete($id);
        echo success();
    }

    /**
     * ajax post => json
     */
    public function save()
    {
        $id = $this->input->post('id');

        if (empty($id)) {
            name = trim($this->input->post('name'));
            if (empty(name)) {
                echo error(400, 'name不能为空');
                return;
            }
        }
        
        $title = $this->input->post('title');
        if (empty($title)) {
            echo error(400, 'title不能为空');
            return;
        }
        
        $data = [
            'title' => title
        ];

        $this->load->model('{table}_model');
        if (empty($id)) {
            $exist = $this->{table}_model->get_by_name($email);
            if (!empty($exist)) {
                echo error(500, '记录已存在');
                return;
            }
            $data['title'] = title;
            $this->{table}_model->insert($data);
        } else {
            $this->{table}_model->update($id, $data);
        }
        echo success();
    }
}
