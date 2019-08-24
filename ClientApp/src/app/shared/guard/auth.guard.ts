import { AuthService } from './../services';
import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { Router } from '@angular/router';


@Injectable()
export class AuthGuard implements CanActivate {
    constructor(
            private router: Router,
            private authenticationService: AuthService
        ) {}

    canActivate() {

        if (this.authenticationService.isLoggedIn()) {
            // authorised so return true

            // console.log('true auth guard' , true);
            return true;
          }

        this.router.navigate(['/login']);
        return false;
    }
}
