<?php 
class ProductsRepo {
    private mysqli $connection;
    private array $products = [];
    public function __construct(string $db) {
        $this->connection = new mysqli('localhost', 'root', '', $db);
        $this->connection->set_charset('utf8');

    }

    public function __destruct() {
        $this -> connection->close();
        $this -> connection = null;
    }
}