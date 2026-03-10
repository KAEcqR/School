import http from 'http';

const server = http.createServer();

const PORT = 3000;
server.listen(PORT, () => {
    console.log(`Serwer dziala na porcie : ${PORT}`);
});