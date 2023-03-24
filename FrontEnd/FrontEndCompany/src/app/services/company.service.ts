import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Company } from '../interfaces/company';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  _baseURL: string = "api/Company";

  constructor(private http: HttpClient) { }

  getAllCompanies() {
    return this.http.get<Company[]>(this._baseURL+"/GetCompanies");
  }
}
