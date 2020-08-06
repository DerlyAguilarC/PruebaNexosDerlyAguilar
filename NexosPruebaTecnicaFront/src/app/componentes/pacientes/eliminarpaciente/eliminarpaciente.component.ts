import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../../servicios/api.service';
declare var $: any;

@Component({
  selector: 'app-eliminarpaciente',
  templateUrl: './eliminarpaciente.component.html',
  styleUrls: ['./eliminarpaciente.component.css']
})
export class EliminarpacienteComponent implements OnInit {

  public idPaciente: number;

  constructor(public apiService: ApiService) {

  }

  ngOnInit(): void {
  }

  EliminarPaciente() {
    this.apiService.eliminarPaciente(this.idPaciente).subscribe(s => {
      $('#btnCancelarEliminarPaciente').click();
    });
  }

}
