import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Sistema } from '../models/sistema';

@Injectable({
  providedIn: 'root'
})
export class SistemaService {

  apiUrl : string = 'http://localhost:5204/Sistemas';

  constructor(private http : HttpClient) { }

  Pesquisar(codigo : number) : Observable<Sistema> {
    return this.http.get<Sistema>(`${this.apiUrl}/${codigo}`);
  }

  Listar() : Observable<Sistema[]> {
    //Início do trecho para alteração
    return this.http.get<Sistema[]>(this.apiUrl);
    //Fim do trecho para alteração
  }

  Incluir(sistema : Sistema) : Observable<any> {
    //Início do trecho para alteração
    return this.http.post(this.apiUrl, sistema);
    //Fim do trecho para alteração
  }

}
