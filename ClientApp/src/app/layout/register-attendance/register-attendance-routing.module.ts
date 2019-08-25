import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RegisterAttendanceComponent } from './register-attendance.component';

const routes: Routes = [
    {
        path: '',
        component: RegisterAttendanceComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class RegisterAttendanceRoutingModule {}
