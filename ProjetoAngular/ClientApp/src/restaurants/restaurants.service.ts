import { Restaurant } from "../restaurant/restaurant.model";
import { MEAT_API } from '../app/app.api'
import { Http } from '@angular/http'
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map, catchError } from 'rxjs/operators'
import { ErrorHandler } from '../app/app.error-handler';

@Injectable()
export class RestaurantsService {
  constructor(private http: Http) { }

  public restaurants(): Observable<Restaurant[]> {
    return this.http.get(`${MEAT_API}/Restaurant`)
      .pipe(map(response => response.json()))
      .pipe(catchError(ErrorHandler.hadlerError));
  }

  public restaurantById(id: string): Observable<Restaurant> {
    return this.http.get(`${MEAT_API}/Restaurant/${id}`)
      .pipe(map(response => response.json()))
      .pipe(catchError(ErrorHandler.hadlerError));
  }

  reviewsOfRestaurant(id: string): Observable<any> {
    return this.http.get(`${MEAT_API}/Restaurant/${id}/Reviews`)
      .pipe(map(response => response.json()))
      .pipe(catchError(ErrorHandler.hadlerError));
  }





}
