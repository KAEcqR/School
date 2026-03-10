import { Router } from "express";
import { connection } from "../dist/db.js";

const router = Router();

// GET all items
router.get("/", async (_req, res) => {
    const [rows] = await connection.query("SELECT * FROM students");
    res.json(rows);
});

// GET one item
router.get("/:id", async (req, res) => {
    const [rows] = await connection.query<any[]>(
        "SELECT * FROM students WHERE id = ?",
        [req.params.id]
    );

    res.json(rows[0] || {});
});

// POST new item
router.post("/", async (req, res) => {
    const { firstname, lastname, birthDate } = req.body;
    await connection.query("INSERT INTO students (firstname, lastname, birthDate) VALUES (?, ?, ?)", [firstname, lastname, birthDate]);
    res.json({ message: "Added!" });
});

// PUT update item
router.put("/:id", async (req, res) => {
    const { firstname, lastname, birthDate } = req.body;
    await connection.query("UPDATE students SET firstname = ?, lastname = ?, birthDate = ? WHERE id = ?",
        [firstname, lastname, birthDate, req.params.id]);
    res.json({ message: "Updated!" });
});

// DELETE item
router.delete("/:id", async (req, res) => {
    await connection.query("DELETE FROM students WHERE id=?", [req.params.id]);
    res.json({ message: "Deleted!" });
});

export default router;
