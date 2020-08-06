import { Component, OnInit, Input } from '@angular/core';
import { ApiService } from '../../../servicios/api.service';
import { Respuestagenerica } from '../../../modelos/respuestagenerica';
import { PacienteAsignadoViewModel } from '../../../modelos/paciente-asignado-view-model';

@Component({
  selector: 'app-verasignarpacientes',
  templateUrl: './verasignarpacientes.component.html',
  styleUrls: ['./verasignarpacientes.component.css']
})
export class VerasignarpacientesComponent implements OnInit {
  public idDoctor: number;
  datasourcePacientes: [];
  displayedColumns: string[] = ['paciente'];
  constructor(public apiService: ApiService) {

  }

  ngOnInit(): void {
    this.cargarListadoPacientesAsignados();
  }

  cargarListadoPacientesAsignados() {
    this.apiService.obtenerPacientesAsignados(this.idDoctor).subscribe(s => {
      let respuesta: Respuestagenerica<PacienteAsignadoViewModel[]> = s as Respuestagenerica<PacienteAsignadoViewModel[]>;
      this.datasourcePacientes = JSON.parse(JSON.stringify(respuesta.objRespuesta))
    });
  }
}
