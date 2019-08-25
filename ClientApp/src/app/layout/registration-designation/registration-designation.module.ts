import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbCarouselModule, NgbAlertModule } from '@ng-bootstrap/ng-bootstrap';
import { PageHeaderModule } from './../../shared';

import { RegistrationDesignationComponent } from './registration-designation.component';
import { RegisterDesignationRoutingModule } from './register-designation-routing.module';
import { FacultyRegistrationComponent } from './faculty-registration/faculty-registration.component';
import { StudentRegistrationComponent } from './student-registration/student-registration.component';

@NgModule({
  imports: [
    CommonModule,
    PageHeaderModule,
    RegisterDesignationRoutingModule
  ],
  declarations: [RegistrationDesignationComponent , FacultyRegistrationComponent , StudentRegistrationComponent ]
})
export class RegistrationDesignationModule { }
