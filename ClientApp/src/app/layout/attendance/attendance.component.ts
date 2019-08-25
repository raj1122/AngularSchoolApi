import { Component, OnInit } from '@angular/core';
import { routerTransition } from 'src/app/router.animations';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.scss']
  , animations: [routerTransition()]
})
export class AttendanceComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
