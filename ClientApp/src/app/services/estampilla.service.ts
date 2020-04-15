import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Estampilla } from '../covid/models/estampilla';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { catchError, tap} from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class EstampillaService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  get(): Observable<Estampilla[]> {
    return this.http.get<Estampilla[]>(this.baseUrl + 'api/Estampilla')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Estampilla[]>('Consulta Estampilla', null))
      );
  }
  post(estampilla: Estampilla): Observable<Estampilla> {
    return this.http.post<Estampilla>(this.baseUrl + 'api/Estampilla', estampilla)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Estampilla>('Registrar Estampilla', null))
      );
  }
}