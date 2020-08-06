import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreardoctorComponent } from './creardoctor.component';

describe('CreardoctorComponent', () => {
  let component: CreardoctorComponent;
  let fixture: ComponentFixture<CreardoctorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreardoctorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreardoctorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
