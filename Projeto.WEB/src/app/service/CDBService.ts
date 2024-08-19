import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';

interface CdbResultModel {
  ValorBruto: number;
  ValorLiquido: number;
  Imposto: number;
}

@Injectable({
  providedIn: 'root',
})
export class CdbService {
  constructor(private http: HttpClient) {}

  calculaCDB(valorInicial: number, meses: number): Observable<any> {
    const payload = { ValorInicial: valorInicial, Meses: meses };
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
    });
    return this.http.post<CdbResultModel>(environment.apiUrl, payload, {
      headers,
    });
  }
}
