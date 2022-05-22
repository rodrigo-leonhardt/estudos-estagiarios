import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-filho',
  templateUrl: './filho.component.html',
  styleUrls: ['./filho.component.css']
})
export class FilhoComponent implements OnInit {

  //Início do trecho para alteração
  
  //Fim do trecho para alteração
  nome : string = '';

  //Início do trecho para alteração
  
  //Fim do trecho para alteração
  indice : number = 0;

  exibir : boolean = true;

  constructor() { }

  ngOnInit(): void {
  }  

}
