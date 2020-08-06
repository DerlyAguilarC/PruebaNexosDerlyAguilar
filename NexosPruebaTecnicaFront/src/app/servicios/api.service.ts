import { Injectable } from '@angular/core';
import { Respuestagenerica } from "../modelos/respuestagenerica";
import { Paciente } from "../modelos/paciente";
import { PacienteAsignadoViewModel } from "../modelos/paciente-asignado-view-model";
import { Doctor } from "../modelos/doctor";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private UrlApi = "https://localhost:44365/api";

  private EndPointObtenerDoctores = `${this.UrlApi}/doctores/ObtenerListadoDoctores`
  private EndPointCrearDoctor = `${this.UrlApi}/doctores/CrearDoctor`
  private EndPointObtenerPacientesAsignados = `${this.UrlApi}/doctores/ObtenerListadoPacientesAsignados`

  private EndPointObtenerPacientes = `${this.UrlApi}/pacientes/ObtenerListadoPacientes`
  private EndPointObtenerPacientePorId = `${this.UrlApi}/pacientes/ObtenerPacientePorId`
  private EndPointCrearPaciente = `${this.UrlApi}/pacientes/CrearPaciente`
  private EndPointEditarPaciente = `${this.UrlApi}/pacientes/ActualizarPaciente`
  private EndPointEliminarPaciente = `${this.UrlApi}/pacientes/EliminarPaciente`

  constructor(private http: HttpClient) { }

  //Inicio Doctores
  public obtenerDoctores(): Observable<Respuestagenerica<Doctor[]>> {
    return this.http.get<Respuestagenerica<Doctor[]>>(this.EndPointObtenerDoctores);
  }

  public obtenerPacientesAsignados(idDoctor: number): Observable<Respuestagenerica<PacienteAsignadoViewModel[]>> {
    return this.http.get<Respuestagenerica<PacienteAsignadoViewModel[]>>(`${this.EndPointObtenerPacientesAsignados}?idDoctor=${idDoctor}`);
  }

  public crearDoctor(nuevoDoctor: Doctor): Observable<boolean> {
    return this.http.post<boolean>(this.EndPointCrearDoctor, nuevoDoctor);
  }
  //Fin Doctores

  //Inicio Pacientes
  public obtenerPacientes(): Observable<Respuestagenerica<Paciente[]>> {
    return this.http.get<Respuestagenerica<Paciente[]>>(this.EndPointObtenerPacientes);
  }

  public obtenerPacientesPorId(idPaciente: number): Observable<Respuestagenerica<Paciente>> {
    return this.http.get<Respuestagenerica<Paciente>>(`${this.EndPointObtenerPacientePorId}?idPaciente=${idPaciente}`);
  }

  public crearPaciente(nuevoPaciente: Paciente): Observable<boolean> {
    return this.http.post<boolean>(this.EndPointCrearPaciente, nuevoPaciente);
  }

  public editarPaciente(editarPaciente: Paciente): Observable<boolean> {
    return this.http.put<boolean>(this.EndPointEditarPaciente, editarPaciente);
  }

  public eliminarPaciente(idPaciente: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this.EndPointEliminarPaciente}?idPaciente=${idPaciente}`);
  }
  //Fin Pacientes
}
