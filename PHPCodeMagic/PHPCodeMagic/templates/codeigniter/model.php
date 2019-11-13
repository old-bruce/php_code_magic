<?php

class {TABLE}_model extends CI_Model {

    public function get($id)
    {
        $query = $this->db->query("SELECT * FROM `{table}` WHERE `id`=$id");
        return $query->row();
    }

	public function get_by_name($name)
    {
        $query = $this->db->query("SELECT * FROM `{table}` WHERE `name`='$name'");
        return $query->row();
    }

    public function all($sort='DESC')
    {
        $query = $this->db->query("SELECT * FROM `{table}` ORDER BY `id` $sort");
        return $query->result();
    }

    public function list($order='id', $sort='DESC')
    {
        $query = $this->db->query("SELECT * FROM `{table}` ORDER BY `$order` $sort");
        return $query->result();
    }

    public function search($key, $order='id', $sort='ASC', $count=100)
    {
        $query = $this->db->query("SELECT * FROM `{table}` WHERE `title` LIKE '%$key%' ORDER BY `$order` $sort LIMIT 0,$count");
        return $query->result();
    }

    public function where($where)
    {
        $query = $this->db->query("SELECT * FROM `{table}` $where");
        return $query->result();
    }

    public function page($page=1, $size=20, $sort='DESC')
    {
        $start = ($page - 1) * $size;
        $query = $this->db->query("SELECT * FROM `{table}` ORDER BY `id` $sort LIMIT $start, $size");
        return $query->result();
    }

    public function count()
    {
        $query = $this->db->query("SELECT count(*) AS count FROM `{table}`");
        return $query->row()->count;
    }

    public function insert($data)
    {
        $this->db->insert('{table}', $data);
        return $this->db->insert_id();
    }

    public function update($id, $data)
    {
        $this->db->where('id', $id);
        $this->db->update('{table}', $data);
    }

    public function delete($id)
    {
        $this->db->delete('{table}', array('id' => $id));
    }
}