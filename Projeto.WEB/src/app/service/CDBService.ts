import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CdbService {
  private apiUrl = 'https://localhost:44302/api/CalculaCDB';

  constructor(private http: HttpClient) {}

  calculaCDB(valorInicial: number, meses: number): Observable<any> {
    const payload = { valorInicial, meses };
    return this.http.post<any>(this.apiUrl, payload);
  }
}
