import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RegistrationDesignationComponent } from './registration-designation.component';


const routes: Routes = [
  {
    path: '', component: RegistrationDesignationComponent
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RegisterDesignationRoutingModule {
}
