import express from "express";
import cors from "cors";
import itemsRoute from "./crud.js";

const app = express();
app.use(cors());
app.use(express.json());

// Route
app.use("/", itemsRoute);

const PORT = 3001;
app.listen(PORT, () => console.log("API running on http://localhost:" + PORT));
