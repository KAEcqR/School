import express from 'express';
import cors from 'cors';

const app = express();
const port = 3000;
app.use(express.json());
// Enable CORS for all routes
app.use(cors());
// app.get('/', (req, res) => {
//   res.send('Hello, World!');
// });
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});