import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EstampillaConsultaComponent } from './covid/estampilla-consulta/estampilla-consulta.component';
import { EstampillaRegistroComponent } from './covid/estampilla-registro/estampilla-registro.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'estampillaConsulta',
    component: EstampillaConsultaComponent
  },
  {
    path: 'estampillaRegistro',
    component: EstampillaRegistroComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
