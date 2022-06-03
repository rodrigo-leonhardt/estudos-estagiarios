import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-componente2',
  templateUrl: './componente2.component.html',
  styleUrls: ['./componente2.component.css']
})
export class Componente2Component implements OnInit {

  nome : string = '';

  constructor(private route: ActivatedRoute) { 
    route.params.subscribe(this.onUpdateRoute.bind(this));    
  }

  ngOnInit(): void {    
  }

  onUpdateRoute(params : Params) : void {
    //Início do trecho para alteração
    
    //Fim do trecho para alteração
  }

}
