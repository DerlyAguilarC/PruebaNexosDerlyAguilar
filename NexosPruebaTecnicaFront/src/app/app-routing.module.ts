import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DoctoresComponent } from './componentes/doctores/doctores.component';
import { PacientesComponent } from './componentes/pacientes/pacientes.component';

const routes: Routes = [
  { path: 'doctores', component: DoctoresComponent },
  { path: 'pacientes', component: PacientesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
