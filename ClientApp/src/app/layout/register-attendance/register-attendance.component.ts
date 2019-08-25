import { Component, OnInit } from '@angular/core';
import { routerTransition } from '../../router.animations';

@Component({
  selector: 'app-register-attendance',
  templateUrl: './register-attendance.component.html',
  styleUrls: ['./register-attendance.component.css']
  , animations: [routerTransition()]
})
export class RegisterAttendanceComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
