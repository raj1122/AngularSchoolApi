import { DeleteRoutingModule } from './delete-account-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbCarouselModule, NgbAlertModule } from '@ng-bootstrap/ng-bootstrap';
import { PageHeaderModule } from './../../shared';

import { DeleteAccountComponent } from './delete-account.component';

@NgModule({
  imports: [
    CommonModule,        
    PageHeaderModule,
    DeleteRoutingModule


  ],
  declarations: [DeleteAccountComponent]
})
export class DeleteAccountModule { }
