import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../servicios/api.service';
import { Respuestagenerica } from '../../modelos/respuestagenerica';
import { Paciente } from '../../modelos/paciente';
import { MatDialog } from '@angular/material/dialog';
import { CreareditarpacienteComponent } from './creareditarpaciente/creareditarpaciente.component';
import { EliminarpacienteComponent } from './eliminarpaciente/eliminarpaciente.component';

@Component({
  selector: 'app-pacientes',
  templateUrl: './pacientes.component.html',
  styleUrls: ['./pacientes.component.css']
})
export class PacientesComponent implements OnInit {

  datasourcePacientes: [];
  displayedColumns: string[] = ['id', 'nombreCompleto', 'numeroSeguroSocial', 'codigoPostal', 'telefonoContacto', 'doctoresAsignados','verPaciente', 'editarPaciente', 'eliminarPaciente'];
  constructor(public dialog: MatDialog, public apiService: ApiService) {

  }

  ngOnInit(): void {
    this.obtenerListadoPacientes();
  }

  abrirCrearEditarPaciente(idPaciente) {
    const dialogRef = this.dialog.open(CreareditarpacienteComponent, {
      width: '500px'
    });

    dialogRef.afterClosed().subscribe(result => {
      this.obtenerListadoPacientes();
    });

    dialogRef.componentInstance.idPaciente = idPaciente;

    dialogRef.componentInstance.ObtenerInformacionPaciente();

  }

  eliminarPaciente(idPaciente) {
    const dialogRef = this.dialog.open(EliminarpacienteComponent, {
      width: '500px'
    });

    dialogRef.afterClosed().subscribe(result => {
      this.obtenerListadoPacientes();
    });

    dialogRef.componentInstance.idPaciente = idPaciente;
  }

  obtenerListadoPacientes() {
    this.apiService.obtenerPacientes().subscribe(s => {
      let respuesta: Respuestagenerica<Paciente[]> = s as Respuestagenerica<Paciente[]>;
      this.datasourcePacientes = JSON.parse(JSON.stringify(respuesta.objRespuesta))
    });
  }

}
