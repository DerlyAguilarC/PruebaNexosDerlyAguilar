import { Component, OnInit } from '@angular/core';
import { CreardoctorComponent } from './creardoctor/creardoctor.component';
import { VerasignarpacientesComponent } from './verasignarpacientes/verasignarpacientes.component';
import { MatDialog } from '@angular/material/dialog';
import { ApiService } from '../../servicios/api.service';
import { Respuestagenerica } from '../../modelos/respuestagenerica';
import { Doctor } from '../../modelos/doctor';

@Component({
  selector: 'app-doctores',
  templateUrl: './doctores.component.html',
  styleUrls: ['./doctores.component.css']
})
export class DoctoresComponent implements OnInit {

  respuestaGenericaDoctores: Respuestagenerica<Doctor[]> = { esError: false, mensajeError: "", objRespuesta: [] }
  displayedColumns: string[] = ['id', 'nombreCompleto', 'especialidad', 'numeroCredencial', 'hospitalTrabajo','asignarVerPacientes'];
  datasourceDoctores: any[]
  constructor(public dialog: MatDialog, public apiService: ApiService) {
  }

  ngOnInit(): void {
    this.cargarListadoDoctores();
  }

  cargarListadoDoctores() {
    this.apiService.obtenerDoctores().subscribe(s => {
      this.respuestaGenericaDoctores = s as Respuestagenerica<Doctor[]>;
      this.datasourceDoctores = JSON.parse(JSON.stringify(this.respuestaGenericaDoctores.objRespuesta))
      console.log(this.datasourceDoctores);
    });
  }


  openDialog() {
    const dialogRef = this.dialog.open(CreardoctorComponent, {
      width: '500px'
    });

    dialogRef.afterClosed().subscribe(result => {
      this.cargarListadoDoctores();
    });
  }

  verAsignarPacientes(idDoctor) {
    const dialogRef = this.dialog.open(VerasignarpacientesComponent, {
      width: '500px'
    });

    dialogRef.componentInstance.idDoctor = idDoctor;
  }




}
