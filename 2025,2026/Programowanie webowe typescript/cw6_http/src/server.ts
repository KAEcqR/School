import http from 'http';
import { handleRoutes } from './router.js';
//tworzenie serwera HTTP
const server = http.createServer(
    // (req, res) => {
    //     res.statusCode = 200;
    //     res.setHeader('Content-Type', 'text/plain');
    //     res.end('Hello, world!');
    // }
    handleRoutes
);


// Inicjalizacja serwera
const PORT = 3000;
server.listen(PORT, () => {
  console.log(`Serwer działa na porcie ${PORT}`);
});