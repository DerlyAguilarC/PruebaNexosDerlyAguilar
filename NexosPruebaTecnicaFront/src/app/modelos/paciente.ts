import { Doctor } from "./doctor";

export interface Paciente {
  id: number,
  nombreCompleto: string,
  numeroSeguroSocial: string,
  codigoPostal: string,
  telefonoContacto: string,
  listadoDoctores: Doctor[]
}
