import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-componente1',
  templateUrl: './componente1.component.html',
  styleUrls: ['./componente1.component.css']
})
export class Componente1Component implements OnInit {

  primeiroNome : string = '';
  ultimoNome : string = '';  

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(value : NgForm) {
    alert(this.primeiroNome +' '+ this.ultimoNome);
  }

}
