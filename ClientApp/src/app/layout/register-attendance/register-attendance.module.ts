import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbCarouselModule, NgbAlertModule } from '@ng-bootstrap/ng-bootstrap';
import { PageHeaderModule } from './../../shared';

import { RegisterAttendanceComponent } from './register-attendance.component';
import { RegisterAttendanceRoutingModule } from './register-attendance-routing.module';

@NgModule({
  imports: [
    CommonModule,
    PageHeaderModule,
    RegisterAttendanceRoutingModule
  ],
  declarations: [RegisterAttendanceComponent]
})
export class RegisterAttendanceModule { }
