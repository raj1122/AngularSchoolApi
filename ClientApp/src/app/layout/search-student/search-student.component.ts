import { Component, OnInit } from '@angular/core';
import { routerTransition } from '../../router.animations';

@Component({
  selector: 'app-search-student',
  templateUrl: './search-student.component.html',
  styleUrls: ['./search-student.component.scss']
  , animations: [routerTransition()]
})
export class SearchStudentComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
