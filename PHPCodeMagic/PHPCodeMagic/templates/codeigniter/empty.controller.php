<?php
defined('BASEPATH') OR exit('No direct script access allowed');

/**
 * {TABLE} Controller 
 */
class {TABLE} extends MY_Controller {
    
    public function all()
    {
        $token = $this->input->post('token');
        if (empty($token)) {
            error(400, 'token is null');
            return;
        }

        $sign = $this->input->post('sign');
        if (empty($sign)) {
            error(400, 'sign is null');
            return;
        }

        if (!$this->check_sign($token, $sign)) {
            error(300, 'sign error');
            return;
        }

        $uid = $this->uid($token);
    }
    
    public function index() {

    }

    public function page($page=1) {

    }

    public function info($id) {

    }

    public function add() {

    }

    public function modify($id) {

    }

    public function save() {
        
    }
}