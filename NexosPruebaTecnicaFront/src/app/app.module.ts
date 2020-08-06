import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DoctoresComponent } from './componentes/doctores/doctores.component';
import { PacientesComponent } from './componentes/pacientes/pacientes.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CreardoctorComponent } from './componentes/doctores/creardoctor/creardoctor.component';

import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import { MatGridListModule } from '@angular/material/grid-list';
import { VerasignarpacientesComponent } from './componentes/doctores/verasignarpacientes/verasignarpacientes.component';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { CreareditarpacienteComponent } from './componentes/pacientes/creareditarpaciente/creareditarpaciente.component';
import { EliminarpacienteComponent } from './componentes/pacientes/eliminarpaciente/eliminarpaciente.component';

@NgModule({
  declarations: [
    AppComponent,
    DoctoresComponent,
    PacientesComponent,
    CreardoctorComponent,
    VerasignarpacientesComponent,
    CreareditarpacienteComponent,
    EliminarpacienteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    MatButtonModule,
    MatTableModule,
    HttpClientModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatGridListModule,
    MatCheckboxModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
