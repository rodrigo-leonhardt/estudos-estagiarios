import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Componente0Component } from './componente0/componente0.component';
import { Componente1Component } from './componente1/componente1.component';
import { Componente2Component } from './componente2/componente2.component';

const routes: Routes = [
  //Início do trecho para alteração
  
  //Fim do trecho para alteração
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
