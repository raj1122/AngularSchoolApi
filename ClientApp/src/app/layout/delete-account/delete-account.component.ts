import { Component, OnInit } from '@angular/core';
import { routerTransition } from 'src/app/router.animations';

@Component({
  selector: 'app-delete-account',
  templateUrl: './delete-account.component.html',
  styleUrls: ['./delete-account.component.scss']
  , animations: [routerTransition()]
})
export class DeleteAccountComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
