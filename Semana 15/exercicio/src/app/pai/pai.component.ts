import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pai',
  templateUrl: './pai.component.html',
  styleUrls: ['./pai.component.css']
})
export class PaiComponent implements OnInit {
  
  nomeNovoFilho : string = '';
  numeroFilhos : number = 0;

  listaFilhos : string[] = [];


  constructor() { }

  ngOnInit(): void {
  }

  incluirFilho() {
    alert(`Incluindo filho "${this.nomeNovoFilho}"`);


    this.listaFilhos.push(this.nomeNovoFilho);

    this.numeroFilhos++;
  }

}
