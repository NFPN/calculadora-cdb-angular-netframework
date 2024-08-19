import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CDBService {
  private apiUrl = 'https://api.exemplo.com/calculate-cdb';

  constructor(private http: HttpClient) {}

  calculaCDB(valorInicial: number, meses: number): Observable<any> {
    const payload = { valorInicial, meses };
    return this.http.post<any>(this.apiUrl, payload);
  }
}
