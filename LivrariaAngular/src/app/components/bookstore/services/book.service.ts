import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()

export class BookService {

  private url = 'https://localhost:44308/api/livraria';

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }

    constructor( private http: HttpClient){}

    getBooks() {
      return this.http.get(this.url)
    }
}
