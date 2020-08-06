import { Component, OnInit } from '@angular/core';
import { Paciente } from '../../../modelos/paciente';
import { ApiService } from '../../../servicios/api.service';
import { Respuestagenerica } from '../../../modelos/respuestagenerica';
declare var $: any;
@Component({
  selector: 'app-creareditarpaciente',
  templateUrl: './creareditarpaciente.component.html',
  styleUrls: ['./creareditarpaciente.component.css']
})
export class CreareditarpacienteComponent implements OnInit {
  public idPaciente: number;
  public nuevoPaciente: Paciente;
  textoBotonCrearEditar: string

  constructor(public apiService: ApiService) {
    this.nuevoPaciente = { listadoDoctores:[], id: 0, codigoPostal: "", nombreCompleto: "", numeroSeguroSocial: "", telefonoContacto: "" };
  }

  ngOnInit(): void {

  }

  public ObtenerInformacionPaciente() {
    if (this.idPaciente !== 0) {
      this.textoBotonCrearEditar = 'Actualizar usuario';
      this.apiService.obtenerPacientesPorId(this.idPaciente).subscribe(s => {
        let respuesta: Respuestagenerica<Paciente> = s as Respuestagenerica<Paciente>;
        this.nuevoPaciente.id = this.idPaciente;
        this.nuevoPaciente.nombreCompleto = respuesta.objRespuesta.nombreCompleto;
        this.nuevoPaciente.numeroSeguroSocial = respuesta.objRespuesta.numeroSeguroSocial;
        this.nuevoPaciente.telefonoContacto = respuesta.objRespuesta.telefonoContacto;
        this.nuevoPaciente.codigoPostal = respuesta.objRespuesta.codigoPostal;
      });
    } else {
      this.textoBotonCrearEditar = 'Crear nuevo usuario';
    }
  }

  guardarNuevoPaciente() {
    if (this.idPaciente === 0) {
      this.apiService.crearPaciente(this.nuevoPaciente).subscribe(s => { $('#btnCancelarCrearPaciente').click(); });
    } else {
      this.nuevoPaciente.id = this.idPaciente;
      this.apiService.editarPaciente(this.nuevoPaciente).subscribe(s => { $('#btnCancelarCrearPaciente').click(); });
    }
  }

}

