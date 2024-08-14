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
    return this.http.get<Restaurant[]>(this._baseURL+"/GetRestaurants");
  }
  getRestaurantById(id:number){
     return this.http.get<Restaurant>(this._baseURL+'/')
  }
  AddRestaurants(restu:Restaurant){
    return this.http.post(this._baseURL+"/AddRestaurant",restu);
  }
  DeleteRestaurants(id:number){
    return this.http.delete(this._baseURL+"/DeleteRestaurant"+id);
  }
}
