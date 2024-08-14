import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {
  _baseURL: string = "https://localhost:7082/api/Books"; // Replace "8080" with your desired port number


  constructor() { }
}
