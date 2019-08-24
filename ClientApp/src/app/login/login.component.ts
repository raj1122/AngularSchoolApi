import { Component, OnInit } from '@angular/core';
import { Router , ActivatedRoute } from '@angular/router';
import { routerTransition } from '../router.animations';

import { AuthService} from '../shared';
import { FormGroup, FormControl, Validators, FormBuilder , ReactiveFormsModule} from '@angular/forms';
import { HttpResponse } from '@angular/common/http';


@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    animations: [routerTransition()]
})
export class LoginComponent implements OnInit {
    invalidLogin: boolean;

    loginform: FormGroup;
    email = new FormControl('deckerwilcox@netility.com', Validators.required);


    constructor(
      public router: Router,
      private route: ActivatedRoute,
      private authService: AuthService,
      private fb: FormBuilder
    ) {

        // this.loginform = fb.group({
        //     'email': this.email,
        //     'pass': ['', Validators.required]
        // });


        this.loginform = this.createFormGroup();

    }

    ngOnInit() {}

    onLoggedin() {
        console.log('value', this.loginform.value);
        localStorage.setItem('isLoggedin', 'true');
        this.authService.login(this.loginform.value)
      .subscribe(result => {
        if (result) {


          const returnUrl = this.route.snapshot.queryParamMap.get('returnUrl');
        
          

          // console.log('return url',returnUrl,',,result in login' , this.authService.currentUser.name);

          this.router.navigate([ '/dashboard' ]);

        }
        else 
        {
            this.invalidLogin = true;
        }
      });

    }

    createFormGroup() {

        return this.fb.group({
            email: this.email,
            pass: ['password', Validators.required]
           });
      }
}
