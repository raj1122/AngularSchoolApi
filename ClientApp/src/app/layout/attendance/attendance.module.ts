import { AttendanceRoutingModule } from './attendance-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AttendanceComponent } from './attendance.component';
import { PageHeaderModule } from 'src/app/shared';

@NgModule({
  imports: [
    CommonModule,        
    PageHeaderModule,
    AttendanceRoutingModule
  ],
  declarations: [AttendanceComponent]
})
export class AttendanceModule { }
