import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  _baseURL: string = "api/Companies";

  constructor(private http: HttpClient) { }

  getAllCompanies() {
    return this.http.get<Company[]>(this._baseURL+"/GetCompanies");
  }
}
