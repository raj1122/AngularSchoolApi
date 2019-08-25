import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LeaveComponent } from './leave.component';
import { PageHeaderModule } from 'src/app/shared';

import { LeaveRoutingModule } from './leave-routing.module';
import { LeaveApplyComponent } from './LeaveApply/LeaveApply.component';
import { LeaveStatusComponent } from './LeaveStatus/LeaveStatus.component';

@NgModule({
  imports: [
    CommonModule
    , PageHeaderModule,
    LeaveRoutingModule
  ],
  declarations: [LeaveComponent , LeaveApplyComponent , LeaveStatusComponent]
})
export class LeaveModule { }
