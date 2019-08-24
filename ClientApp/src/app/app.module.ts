import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule , FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LanguageTranslationModule } from './shared/modules/language-translation/language-translation.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthGuard } from './shared';
import { AuthService } from './shared';
import { JwtModule } from '@auth0/angular-jwt';

export function getAccessToken(): string {
    return localStorage.getItem('token');
  }

export const jwtConfig = {
    tokenGetter: getAccessToken,
    whiteListedDomains: ['localhost:5000']
  };


@NgModule({
    imports: [
        CommonModule,
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        LanguageTranslationModule,
        ReactiveFormsModule,
        FormsModule,
        AppRoutingModule,
        JwtModule.forRoot({
            config: jwtConfig
          })
    ],
    declarations: [AppComponent],
    providers: [AuthGuard , AuthService] ,
    bootstrap: [AppComponent]
})
export class AppModule {}
