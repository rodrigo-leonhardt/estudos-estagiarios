import { Component, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { MeuDado } from './MeuDado';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  meusDados : MeuDado[] = [
    { Nome : 'Albert', Sobrenome : 'Einstein' },
    { Nome : 'Marie', Sobrenome : 'Curie' },
    { Nome : 'Isaac', Sobrenome : 'Newton' },
    { Nome : 'Louis', Sobrenome : 'Pasteur' },
    { Nome : 'Thomas', Sobrenome : 'Edison' },
    { Nome : 'Galileo', Sobrenome : 'Galilei' },
    { Nome : 'Nikola', Sobrenome : 'Tesla' },
    { Nome : 'Ada', Sobrenome : 'Lovelace' },
    { Nome : 'Stephen', Sobrenome : 'Hawking' },
  ];

  meuDataSource = new MatTableDataSource(this.meusDados);

  minhasColunas : string[] = ['Nome', 'Sobrenome'];  

  @ViewChild(MatPaginator) set matPaginator(paginator : MatPaginator) {
    this.meuDataSource.paginator = paginator;
  }  

  @ViewChild(MatSort) set matSort(sort : MatSort) {
    this.meuDataSource.sort = sort;
  }   

  meuFormulario = new FormGroup({
    controleNome : new FormControl('', Validators.required),
    controleSobrenome : new FormControl('', Validators.required)
  });

  onSubmit() {
    var meuDado = new MeuDado();
    meuDado.Nome = this.meuFormulario.controls['controleNome'].value;
    meuDado.Sobrenome = this.meuFormulario.controls['controleSobrenome'].value;
    
    this.meusDados.push(meuDado);

    this.meuDataSource.data = this.meusDados;      
  }

}
