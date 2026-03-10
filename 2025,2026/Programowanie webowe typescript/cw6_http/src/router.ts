import type { IncomingMessage, ServerResponse } from "node:http";
import {type Book, books} from './data/my-books.js';
import fs, { readFileSync } from "node:fs";
import path from "node:path";
import { fileURLToPath } from "node:url";

export const handleRoutes = (req: IncomingMessage, res: ServerResponse) => { 
    if(req.url === '/' && req.method === 'GET'){
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/plain');
        return res.end('Hello, world!');
    }else if(req.url==='/about' && req.method==='GET'){
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        return res.end('<h1>About Page</h1><p>lorem ipsum</p>');
    }else if(req.url === '/books' && req.method === 'GET'){
        res.statusCode = 200;
        res.setHeader('Content-Type', 'application/json');
        return res.end(JSON.stringify(books));
    }else if(req.url==='/index'){
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        const html = readFileSync('./public/index.html', 'utf-8');
        return res.end(html);
    }
    if(req.url?.startsWith('/public/')){
        useStaticFiles(req, res);
    }
    
    else{
        res.statusCode = 404;
        res.setHeader('Content-Type', 'text/html');
        return res.end('<h1>Not Found</h1>');
    }
    //useStaticFiles(req, res);
};

function useStaticFiles(req: IncomingMessage, res: ServerResponse<IncomingMessage>) {
    const _filename = fileURLToPath(import.meta.url);
    const _dirname = path.dirname(_filename);
    console.log(_dirname);
    const file = req.url || '';
    const filePath = path.join(_dirname, '..', file);
    console.log(filePath);//pełna ścieżka do pliku
    let contentType = 'text/plain';
    let extname = path.extname(filePath);//pobranie rozszerzenia pliku
    //const content='';
    switch(extname){
        case '.css':
            contentType = 'text/css';
            break;
        case '.js':
            contentType = 'text/javascript';
            break;
            case '.jpg':
            contentType = 'image/jpg';
            break;
            case '.png':
            contentType = 'image/png';
            break;
            case '.jpeg':
            contentType = 'image/jpeg';
            break;
    };
    fs.readFile(filePath, (err, content) => {
        if(err){
            res.writeHead(404,{'content-type':'text/html'});
            return res.end('<h1>File not Found</h1>');
        }
        res.writeHead(200,{'content-type':contentType});
        return res.end(content);
    });

    //return res.end(content);
}
