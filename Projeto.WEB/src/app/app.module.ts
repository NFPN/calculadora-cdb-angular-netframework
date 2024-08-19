import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalculaCdbComponent } from './calcula-cdb/calcula-cdb.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

import { NgxMaskDirective, NgxMaskPipe, provideNgxMask } from 'ngx-mask';

import { provideHttpClient } from '@angular/common/http'; // Usando o novo provedor
import { enableProdMode } from '@angular/core';
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}

@NgModule({
  declarations: [AppComponent, CalculaCdbComponent],
  imports: [
    AppRoutingModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    NgxMaskDirective,
    NgxMaskPipe,
  ],
  providers: [provideAnimationsAsync(), provideNgxMask(), provideHttpClient()],
  bootstrap: [AppComponent],
})
export class AppModule {}
