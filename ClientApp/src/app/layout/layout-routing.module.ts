import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutComponent } from './layout.component';

const routes: Routes = [
    {
        path: '',
        component: LayoutComponent,
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'prefix' },
            { path: 'dashboard', loadChildren: () => import('./dashboard/dashboard.module').then(m => m.DashboardModule) },
            { path: 'profile', loadChildren: () => import('./Profile/Profile.module').then(m => m.ProfileModule) },
            { path: 'leave', loadChildren: () => import('./Leave/Leave.module').then(m => m.LeaveModule)
                , data : {some_data : 'some value'}
            },
            { path: 'attendance', loadChildren: () => import('./attendance/attendance.module').then(m => m.AttendanceModule) },
            { path: 'regattendance', loadChildren: () => import('./register-attendance/register-attendance.module')
                .then(m => m.RegisterAttendanceModule)
            },
            { path: 'searchstudent', loadChildren: () => import('./search-student/search-student.module').
                then(m => m.SearchStudentModule)
            },
            { path: 'deleteaccount', loadChildren: () => import('./delete-account/delete-account.module')
                .then(m => m.DeleteAccountModule)
            },
            { path: 'regdesignation', loadChildren: () => import('./registration-designation/registration-designation.module')
                .then(m => m.RegistrationDesignationModule)
            },

            { path: 'charts', loadChildren: () => import('./charts/charts.module').then(m => m.ChartsModule) },
            { path: 'tables', loadChildren: () => import('./tables/tables.module').then(m => m.TablesModule) },
            { path: 'forms', loadChildren: () => import('./form/form.module').then(m => m.FormModule) },
            { path: 'bs-element', loadChildren: () => import('./bs-element/bs-element.module').then(m => m.BsElementModule) },
            { path: 'grid', loadChildren: () => import('./grid/grid.module').then(m => m.GridModule) },
            { path: 'components', loadChildren: () => import('./bs-component/bs-component.module').then(m => m.BsComponentModule) },
            { path: 'blank-page', loadChildren: () => import('./blank-page/blank-page.module').then(m => m.BlankPageModule) }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LayoutRoutingModule {}
