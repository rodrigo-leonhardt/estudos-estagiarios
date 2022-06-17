import { Component, OnInit } from '@angular/core';
import { Sistema } from './models/sistema';
import { SistemaService } from './services/sistema.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  sistemas : Sistema[] = [];

  constructor(private sistemaService : SistemaService) {

  }
  ngOnInit(): void {
    this.listarSistemas();
  }
  
  listarSistemas() {
    
    this.sistemaService.Listar().subscribe(
      sucesso => this.sistemas = sucesso
      );    

  }

  incluirSistema() {
    var nomeDigitado = prompt('Informe o nome do novo sistema', 'Solar');

    if (nomeDigitado == null)
      return;

    var sistema : Sistema = { codigo : 0, nome : nomeDigitado };

    //Início do trecho para alteração
    this.listarSistemas();    
    //Fim do trecho para alteração
  }

  pesquisarSistema() {
    var codigoDigitado = prompt('Informe o código do sistema', '1');

    if (codigoDigitado == null)
      return;

    var codigo = Number.parseInt(codigoDigitado);

    //Início do trecho para alteração
    alert('mensagem');
    //Fim do trecho para alteração

  }

}
