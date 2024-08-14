import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Restaurant } from 'src/app/Interfaces/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {
  _baseURL: string = "https://localhost:7082/api/restaurant"; // Replace "8080" with your desired port number


  constructor(private http: HttpClient) { }

  getAllRestaurants(){
    return this.http.get<Restaurant[]>(this._baseURL+"/GetRest")
  }
}
