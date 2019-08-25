import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChartsModule as Ng2Charts } from 'ng2-charts';
import { PageHeaderModule } from '../../shared';

import { SearchStudentComponent } from './search-student.component';
import { SearchStudentRoutingModule } from './search-student-routing.module';

@NgModule({
  imports: [
    CommonModule,
    Ng2Charts,
    PageHeaderModule,
    SearchStudentRoutingModule
  ],
  declarations: [SearchStudentComponent]
})
export class SearchStudentModule { }
