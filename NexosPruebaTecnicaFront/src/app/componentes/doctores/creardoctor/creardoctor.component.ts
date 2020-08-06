import { Component, OnInit } from '@angular/core';
import { Doctor } from '../../../modelos/doctor';
import { ApiService } from '../../../servicios/api.service';
declare var $: any;

@Component({
  selector: 'app-creardoctor',
  templateUrl: './creardoctor.component.html',
  styleUrls: ['./creardoctor.component.css']
})
export class CreardoctorComponent implements OnInit {
  public nuevoDoctor: Doctor;  
  constructor(public apiService: ApiService) {
  }

  ngOnInit(): void {
    this.nuevoDoctor = { especialidad: "", hospitalTrabajo: "", id: 0, nombreCompleto: "", numeroCredencial: "" };
  }

  guardarNuevoDoctor(): void {
    this.apiService.crearDoctor(this.nuevoDoctor).subscribe(s => { $('#btnCancelarCrearDoctor').click(); });
  }
}
