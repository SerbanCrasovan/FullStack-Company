import { Component, OnInit } from '@angular/core';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css']
})
export class CompaniesComponent implements OnInit{
  
  public companies: Company[] = [];

  constructor(private service: CompanyService) { }

  ngOnInit(): void {
    this.service.getAllCompanies().subscribe(data => {
      this.companies = data;
    })
  }


}
