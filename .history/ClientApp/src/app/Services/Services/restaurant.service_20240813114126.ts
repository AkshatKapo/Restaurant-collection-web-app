import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Restaurant } from 'src/app/Interfaces/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {
  _baseURL: string = "https://localhost:7082/api/restaurant"; // Replace "8080" with your desired port number


  constructor(private http: HttpClient) { }
  // Makes a GET Request to URL Link to get all Restaurants
  getAllRestaurants(){
    return this.http.get<Restaurant[]>(this._baseURL+"/GetRestaurants");
  }
  // Makes a GET Request to URL link to get the specified restaurant info with that id 
  getRestaurantById(id:number){
     return this.http.get<Restaurant>(this._baseURL+"/GetRestaurantById/"+id);
  }
  // Makes a POST Request to the url link to add a new restaurant 
  AddRestaurants(restu:Restaurant){
    return this.http.post(this._baseURL+"/AddRestaurant",restu);
  }
  
  DeleteRestaurants(id:number){
    return this.http.delete(this._baseURL+"/DeleteRestaurant/"+id);
  }
}
