import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


import { environment } from '../../../environments/environment';
import { JwtHelperService } from '@auth0/angular-jwt';
import { map} from 'rxjs/operators';
import { pipe} from 'rxjs';


@Injectable()
export class AuthService {

  constructor(private http: HttpClient,
              private helperJWT: JwtHelperService) {
  }

  login(credentials) {
    let headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});

    return this.http.post( `${environment.API_URL}/api/auth/login`, JSON.stringify(credentials) ,
      {headers: headers}
      )
      .pipe(map( (response: any ) => {
        

        const result =  response;
        console.log(result);


        // console.log('response', result.token);
        if ( result && result.tokenString) {
          localStorage.setItem('token' , result.tokenString);


          return true;
        }
        else {
          return false;
        }
    }));
  }

  logout() {
    localStorage.removeItem('token');
  }

  isLoggedIn() {

    const token = this.helperJWT.tokenGetter();
    // console.log('token',token);
    if ( !token) {
      return false;
    }
    return !this.helperJWT.isTokenExpired(token);
    // return tokenNotExpired();
  }

  get currentUser() {

    const token = localStorage.getItem('token');

    if (!token) { return null; }

    // console.log('jwt' , jwtHelper.decodeToken('token').name);
    return this.helperJWT.decodeToken(token);

  }


  getOrders() {
    // let token = localStorage.getItem('token');
    // let headers = new Headers();
    // headers.append('Authorization' , 'Bearer ' + token);

    // console.log( 'oderservcie' , this.http.get('/api/orders') );


    // console.log( 'order servee in auth' , `${environment.API_URL}/api/orders`,'and',this.http.get(`${environment.API_URL}/api/orders` ));
    return this.http.get(`${environment.API_URL}/api/orders` );

  }

}

