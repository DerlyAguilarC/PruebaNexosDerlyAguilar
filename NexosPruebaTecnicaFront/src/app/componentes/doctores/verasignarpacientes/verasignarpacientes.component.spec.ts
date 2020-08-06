import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VerasignarpacientesComponent } from './verasignarpacientes.component';

describe('VerasignarpacientesComponent', () => {
  let component: VerasignarpacientesComponent;
  let fixture: ComponentFixture<VerasignarpacientesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VerasignarpacientesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VerasignarpacientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
